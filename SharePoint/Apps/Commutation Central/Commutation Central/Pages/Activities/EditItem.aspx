﻿<%@ Page Language="C#" MasterPageFile="~masterurl/default.master" Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage, Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<asp:Content ContentPlaceHolderID="PlaceHolderAdditionalPageHead" runat="server">
    <script type="text/javascript" src="../../Scripts/jquery-1.8.2.js"></script>
    <script type="text/javascript" src="../../Scripts/jquery-ui.js"></script>
    <script type="text/javascript" src="../../Scripts/CompatibilityCheck.js"></script>
    <script type="text/javascript" src="../../Scripts/jquery.validate.js"></script>
    <script type="text/javascript" src="../../Scripts/Activities/EditItem.js"></script>
    <script type="text/javascript" src="../../Scripts/QuickLaunch/QuickLaunch.js"></script>
    <script type="text/javascript" src="../../Scripts/Documents/DocumentManagement.js"></script>
    <script type="text/javascript" src="https://cdn.datatables.net/1.10.2/js/jquery.dataTables.min.js"></script>
    <link rel="Stylesheet" href="../../Content/ItemForm.css" />
    <link rel="Stylesheet" href="../../Content/jQueryUI/StyleSheets/jquery-ui.css" />
    <link rel="Stylesheet" href="../../Content/jQueryValidation/screen.css" />
    <link rel="Stylesheet" href="https://cdn.datatables.net/1.10.2/css/jquery.dataTables.min.css" />
</asp:Content>

<asp:Content ContentPlaceHolderID="PlaceHolderMain" runat="server">
    <WebPartPages:WebPartZone runat="server" FrameType="TitleBarOnly" ID="full" Title="loc:full" />
    <table class="parentTable" id="newItemContent">
        <tr>
            <td class="leftBorderColumn" rowspan="2" style="min-width: 30px;"></td>
            <td class="formHeaderRow" style="width: auto; min-width: 930px;">
                <h1>Activity</h1>
            </td>
        </tr>
        <tr>
            <td class="formMainContent">
                <div class="contentRow"></div>
                <div class="contentRow">
                    <table class="childTable" style="width: 100%">
                        <col width="125" />
                        <col />
                        <col width="105" />
                        <col />
                        <col width="155" />
                        <tr>
                            <td class="subHeaderRow" colspan="6">
                                <h2 id="editActivityTitle">Activity for Project</h2>
                            </td>
                        </tr>
                        <tr style="display: none">
                            <td class="errorCell" colspan="6" id="errorCell">
                                <h4>Placeholder error</h4>
                            </td>
                        </tr>
                        <tr>
                            <td class="contentCell"></td>
                            <td class="contentCell"></td>
                            <td class="contentCell">
                                <h4>Created By:</h4>
                            </td>
                            <td class="contentCell">
                                <label id="createdBy" />
                            </td>
                            <td class="contentCell">
                                <h4>Entry Date:</h4>
                            </td>
                            <td class="contentCell">
                                <label id="entryDate" />
                            </td>
                        </tr>
                        <tr>
                            <td class="contentCell">
                                <h4>Initial Due Date:</h4>
                            </td>
                            <td class="contentCell">
                                <label id="initialDueDate" />
                            </td>
                            <td class="contentCell">
                                <h4>Modified By:</h4>
                            </td>
                            <td class="contentCell">
                                <label id="modifiedBy" />
                            </td>
                            <td class="contentCell">
                                <h4>Modified Date:</h4>
                            </td>
                            <td class="contentCell">
                                <label id="modifiedDate" />
                            </td>
                        </tr>
                        <tr>
                            <td class="contentCell">
                                <h4>Description:</h4>
                            </td>
                            <td class="contentCell" colspan="5">
                                <input type="text" name="description" id="description" style="width: 100%" required />
                            </td>
                        </tr>
                        <tr>
                            <td class="contentCell">
                                <h4>Category:</h4>
                            </td>
                            <td class="contentCell">
                                <select name="category" id="category" style="width: 100%" required />
                            </td>
                            <td class="contentCell">
                                <h4>Assigned To:</h4>
                            </td>
                            <td class="contentCell">
                                <SharePoint:ClientPeoplePicker ID="assignedTo" runat="server"
                                    PrincipalAccountType="User"
                                    PrincipalSource="All"
                                    AllowMultipleEntities="false"
                                    MaximumEntitySuggestions="50"
                                    Width="100%"
                                    InitialHelpText="Assigned To" />
                            </td>
                            <td class="contentCell">
                                <h4>Priority</h4>
                            </td>
                            <td class="contentCell">
                                <select name="priority" id="priority" style="width: 100%" />
                            </td>
                        </tr>
                        <tr>
                            <td class="contentCell">
                                <h4>Due Date:</h4>
                            </td>
                            <td class="contentCell">
                                <div style="width: auto; white-space: nowrap" id="dueDateContainer">
                                    <input type="date" name="dueDate" id="dueDate" style="width: 90px" class="datefield" />
                                </div>
                            </td>
                            <td class="contentCell">
                                <h4>Status:</h4>
                            </td>
                            <td class="contentCell">
                                <select name="status" id="status" style="width: 100%" required />
                            </td>
                            <td class="contentCell">
                                <h4>Status Changed Date:</h4>
                            </td>
                            <td class="contentCell">
                                <label id="statusChangedDate" />
                            </td>
                        </tr>
                        <tr class="hiddenContentCell">
                            <td class="contentCell">
                                <h4>Dropped Reason:</h4>
                            </td>
                            <td class="contentCell">
                                <select name="droppedReason" id="droppedReason" style="width:100%" />
                            </td>
                            <td class="contentCell"></td>
                            <td class="contentCell"></td>
                            <td class="contentCell"></td>
                            <td class="contentCell"></td>
                        </tr>
                    </table>
                </div>
                <div class="contentRow">&nbsp;</div>
                <div class="contentRow">
                    <table class="childTable" style="width: 100%">
                        <tr>
                            <td class="subHeaderRow">
                                <h2>Document</h2>
                            </td>
                        </tr>
                        <tr>
                            <td class="contentCell">
                                <input type="file" id="getActivityFile" style="width: 400px;" onchange="FileUploadFieldChanged('Activity Document', 'getActivityFile', 'Activity')" class="fileUpload" /><br />
                            </td>
                        </tr>
                        <tr>
                            <td class="contentCell">
                                <table id="activityDocuments" class="childTable display">
                                    <thead>
                                        <tr>
                                            <th style="width: 0px"></th>
                                            <th style="text-align: left">Filename</th>
                                            <th style="text-align: left">Document ID</th>
                                            <th style="text-align: left">Date Modified</th>
                                            <th style="text-align: left">Modified By</th>
                                            <th style="text-align: left">Version</th>
                                        </tr>
                                    </thead>
                                    <tbody style="text-align: left">
                                    </tbody>
                                </table>
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <input type="submit" class="submit" value="Submit" id="btnSubmit" />
                <button type="button" id="btnCancel" onclick="CancelSubmit()">Cancel</button>
            </td>
        </tr>
    </table>
    <div id="loadingdialog" title="Loading..." style="display: none; text-align: center;">
        <img alt="Loading..." src="../../Images/loading.gif" />
    </div>
    <div id="savingdialog" title="Saving Changes..." style="display: none; text-align: center;">
        <img alt="Saving..." src="../../Images/uploading.gif" />
    </div>
</asp:Content>
