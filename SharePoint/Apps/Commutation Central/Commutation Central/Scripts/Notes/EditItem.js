﻿var appweburl;
var currentItemValues;

// When the DOM is ready, begin code execution
$(document).ready(function () {
    InitializeGlobalVars();
    InitializeFields();
    InitializeValidation();
});

//===============================
// Initialization
//===============================

// Show the loading animation
$(function () {
    $("#loadingdialog").dialog({
        dialogClass: "no-close",
        position: { my: "center", at: "center", of: $("#newItemContent") },
        modal: true,
        resizable: false
    });
});

// Initialize any required global variables
function InitializeGlobalVars() {
    //appweburl = decodeURIComponent(getQueryStringParameter("SPAppWebUrl"));
    appweburl = _spPageContextInfo.webServerRelativeUrl;
}

// Initialize any fields that aren't automatically built in the DOM
function InitializeFields() {
    var currentItem = GetCurrentItem();
    currentItem.done(function (item, status, xhr) {
        currentItemValues = item;
        $("#counterpartyName").text(item.d.Project.Title);
        $("#noteEntryType").text(item.d.EntryType.Title);
        $("#author").text(item.d.Author.Title);
        $("#entryDate").text(new Date(item.d.Modified).format("M/d/yyyy h:mm tt"));
        $("#content1").val(item.d.Content1);
        $("#content1").jqte();
        var getNoteDocs = GetNoteDocuments();
        getNoteDocs.done(function (noteDocuments, status, xhr) {
            var dataTable = $("#noteDocuments").DataTable({
                "autoWidth": false,
                "columnDefs": [
                    { "searchable": false, "targets": 0 },
                    { "orderable": false, "targets": 0 }
                ],
                "order": [1, 'asc']
            });
            FillNoteDocumentsTable(noteDocuments.d.results);
        });
        getNoteDocs.fail(function (status, xhr) {
            displayNoteError(status);
        });
        if ($("#loadingdialog").dialog("isOpen") === true) {
            $("#loadingdialog").dialog("close");
        }
    });
    currentItem.fail(function (status, xhr) {
        displayNoteError(status);
    });
}

// Initialize the form validator
function InitializeValidation() {
    $("#aspnetForm").validate({
        submitHandler: function (form) {
            SubmitForm();
        }
    });
}

//===============================
// End Initialization
//===============================

//===============================
// Field Updates
//===============================

// Handle a file upload field change
function FileUploadFieldChanged(contentType, sender, lookupField) {
    uploadDocument($("#" + sender), contentType, lookupField, getQueryStringParameter("ID"), currentItemValues.d.Project.Title, RenderNoteDocuments);
    var control = $("#" + sender);
    control.replaceWith(control = control.clone(true));
}

//===============================
// End Field Updates
//===============================

//===============================
// Form Submit
//===============================

function SubmitForm() {
    if ($("#content1").val().length === 0) {
        displayNoteError("Please enter Note contents");
        return;
    }
        if ($("#aspnetForm").valid()) {
            $("#savingdialog").dialog({
                dialogClass: "no-close",
                position: { my: "center", at: "center", of: $("#newItemContent") },
                modal: true,
                resizable: false,
                height: 120
            });

            var theForm = $("#aspnetForm")[0];

            var itemData = {
                '__metadata': currentItemValues.d.__metadata,
                'Content1': $("#content1").val()
            };

            $.ajax({
                url: itemData.__metadata.uri,
                type: "POST",
                contentType: "application/json;odata=verbose",
                data: JSON.stringify(itemData),
                headers: {
                    "Accept": "application/json;odata=verbose",
                    "X-RequestDigest": $("#__REQUESTDIGEST").val(),
                    "X-HTTP-Method": "MERGE",
                    "If-Match": itemData.__metadata.etag
                },
                error: function (data) {
                    displayNoteError(data);
                },
                complete: function (jqXHR, textStatus) {
                    $("#savingdialog").dialog("close");
                    if (textStatus == "success") {
                        if (getQueryStringParameter("IsDlg") == "1") {
                            window.commonModalDialogClose(1, 1);
                        }
                        else {
                            if (getQueryStringParameter("Source")) {
                                var sourceParam = "Source=" + getQueryStringParameter("Source") + "&";
                                window.location = getQueryStringParameter("Source") + "?" + decodeURIComponent(document.URL.split("?")[1].replace(sourceParam, ""));
                            } else {
                                window.location = appweburl;
                            }
                        }
                    }
                }
            });
        }
}

// Cancel the submit
function CancelSubmit() {
    if (getQueryStringParameter("IsDlg") == "1") {
        window.commonModalDialogClose(0, 0);
    }
    else {
        if (getQueryStringParameter("Source")) {
            var sourceParam = "Source=" + getQueryStringParameter("Source") + "&";
            window.location = getQueryStringParameter("Source") + "?" + decodeURIComponent(document.URL.split("?")[1].replace(sourceParam, ""));
        } else {
            window.location = appweburl;
        }
    }
}

//===============================
// End Form Submit
//===============================

//===============================
// Utilities
//===============================

// Return a query string parameter
function getQueryStringParameter(paramToRetrieve) {
    var params = document.URL.split("?")[1].split("&");
    for (var i = 0; i < params.length; i = i + 1) {
        var singleParam = params[i].split("=");
        if (singleParam[0] == paramToRetrieve)
            return singleParam[1];
    }
}

// Display an error message (typically failed AJAX calls)
function displayNoteError(data) {
    if ($("#loadingdialog").dialog("isOpen") === true) {
        $("#loadingdialog").dialog("close");
    }
    var responseText = $.parseJSON(data.responseText);
    var error;
    if (responseText) { error = responseText.error.message.value; }
    else { error = data; }
    $("#errorCell").css('visibility', 'visible').html("<h4>" + error + "</h4").parent("tr").show();
    alert(error);
}


// Get a specific list item
function GetSpecificItem(listName, itemId) {
    var endpointUrl = appweburl + "/_api/web/lists/getbytitle('" + listName + "')/items(" + itemId + ")";
    return $.ajax({
        url: endpointUrl,
        type: "GET",
        headers: { "accept": "application/json;odata=verbose" }
    });
}

// Get all the items in a lookup list
function GetLookups(listName, orderBy, direction, top) {
    var endpointUrl = appweburl + "/_api/web/lists/getbytitle('" + listName + "')/items?";
    if (orderBy && direction) { endpointUrl += "&$OrderBy=" + orderBy + " " + direction; }
    if (top) { endpointUrl += "&$top=" + top; }
    return $.ajax({
        url: endpointUrl,
        type: "GET",
        headers: { "accept": "application/json;odata=verbose" }
    });
}

// Get the choices of a choice column local to a SP List
function GetLocalChoiceLookups(listName, columnName) {
    var endpointUrl = appweburl + "/_api/web/lists/getbytitle('" + listName + "')/fields/getbytitle('" + columnName + "')/choices";
    return $.ajax({
        url: endpointUrl,
        type: "GET",
        headers: { "accept": "application/json;odata=verbose" }
    });
}

// Gets a user object from the SharePoint site using a login name
function GetUserFromLogin(loginName) {
    var siteUrl = appweburl + "/_api/web/siteusers(@v)?@v='" + encodeURIComponent(loginName) + "'";

    return $.ajax({
        url: siteUrl,
        method: "GET",
        headers: { "Accept": "application/json; odata=verbose" }
    });
}

// Get the currently opened item
function GetCurrentItem() {
    var endpointUrl = appweburl + "/_api/web/lists/getbytitle('Notes')/items(" + getQueryStringParameter("ID") + ")?$select=*,Project/Title,Author/Title,Editor/Title,EntryType/Title&$expand=Project,Author,Editor,EntryType";

    return $.ajax({
        url: endpointUrl,
        method: "GET",
        headers: { "Accept": "application/json;odata=verbose" }
    });
}

// Render the note documents
function RenderNoteDocuments() {
    GetNoteDocuments().done(function (results) {
        FillNoteDocumentsTable(results.d.results);
    }).fail(function (status) {
        displayNoteError(status);
    });
}

// Get activity documents
function GetNoteDocuments() {
    // Endpoint URL must be constructed differently for lookup columns
    var endpointUrl = appweburl + "/_api/lists/getbytitle('Commutation Documents')/Items/?$filter=Note/Id eq " + getQueryStringParameter("ID") + "&$expand=File/ModifiedBy";
    return $.ajax({
        url: endpointUrl,
        type: "GET",
        headers: { "accept": "application/json;odata=verbose" }
    });
}

// Fill the project documents table
function FillNoteDocumentsTable(results) {
    var dataTable = $("#noteDocuments").DataTable();
    dataTable.clear().draw();
    $.each(results, function (i, item) {
        var itemUrl = escapeHtml(item.__metadata.uri);
        var itemEtag = item.__metadata.etag;
        dataTable.row.add([
            "<a class='deleteItemLink' style='color:blue' href='javascript:void(0)' onClick='DeleteNoteDocument(\"" + itemUrl + "\"," + itemEtag + ", true, \"Note Document\")'><span class=' ms-cui-img-16by16 ms-cui-img-cont-float' unselectable='on'><img style='left: -271px; top: -271px;' alt='' src='/_layouts/15/1033/images/formatmap16x16.png?rev=23' unselectable='on'/></span></a>",
            "<a style='color:blue' href='" + item.File.ServerRelativeUrl + "'>" + item.File.Name + "</a>",
            item.OData__dlc_DocId,
            new Date(item.Modified).format('MM/dd/yyyy hh:mm tt'),
            item.File.ModifiedBy.Title,
            item.File.MajorVersion + "." + item.File.MinorVersion
        ]).draw();
    });
    ResizeDialogWindow();
}

// Resize the dialog window
function ResizeDialogWindow() {
    var dlg = SP.UI.ModalDialog.get_childDialog();
    if (dlg != null) {
        dlg.autoSize();
    }
}

// Escape a string to be HTML compliant
function escapeHtml(text) {
    var map = {
        '&': '&amp;',
        '<': '&lt;',
        '>': '&gt;',
        '"': '&quot;',
        "'": '&#039;'
    };

    return text.replace(/[&<>"']/g, function (m) { return map[m]; });
}

// Deletes a list item
function DeleteNoteDocument(itemUrl, itemEtag, renderClient, contentType) {
    if (confirm('Are you sure you want to delete this ' + contentType + '?')) {
        var deleteItem = ExecuteDelete();
        deleteItem.done(function (something, status, xhr) {
            if (renderClient) {
                switch (contentType) {
                    case "Note Document":
                        RenderNoteDocuments();
                        break;
                }
            }
        });
        deleteItem.fail(function (status, xhr) {
            displayNoteError(status);
        });
    }

    function ExecuteDelete() {
        var endpointUrl = decodeURIComponent(itemUrl);
        return $.ajax({
            url: endpointUrl,
            type: "POST",
            headers: {
                "Accept": "application/json;odata=verbose",
                "X-Http-Method": "DELETE",
                "X-RequestDigest": $("#__REQUESTDIGEST").val(),
                "If-Match": "*"
            }
        });
    }
}

//===============================
// End Utilities
//===============================