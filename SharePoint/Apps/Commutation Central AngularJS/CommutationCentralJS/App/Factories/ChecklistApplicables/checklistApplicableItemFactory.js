﻿(function () {
    'use strict';

    angular
        .module('commutationCentral')
        .factory('checklistApplicableItemFactory', ['baseItemFactory', function (baseService) {
            var listEndPoint = '/_api/web/lists';
            var listName = 'Checklist Applicable Lookup';
            var getAll = function () {
                var query = listEndPoint + "/GetByTitle('" + listName + "')/Items?$select=ID,ChecklistApplicableName";
                return baseService.getRequest(query);
            };
            var addNew = function (item) {
                var data = {
                    __metadata: {
                        'type': 'SP.Data.ChecklistApplicableLookupListItem'
                },
                    ChecklistApplicableName: item.ChecklistApplicableName
                };
                var url = listEndPoint + "/GetByTitle('" + listName + "')/Items";
                return baseService.postRequest(data, url);
            };
            var getById = function (itemId) {
                var query = listEndPoint + "/GetByTitle('" + listName + "')/GetItemById(" + itemId + ")?$select=ID,ChecklistApplicableName";
                return baseService.getRequest(query);
            };
            var update = function (item) {
                var data = {
                    __metadata: {
                        'type': 'SP.Data.ChecklistApplicableLookupListItem'
                    },
                   ChecklistApplicableName: item.ChecklistApplicableName
                };
                var url = listEndPoint + "/GetByTitle('" + listName + "')/GetItemById(" + item.itemId + ")";
                return baseService.updateRequest(data, url);
            };
            var remove = function (itemId) {
                var url = listEndPoint + "/GetByTitle('" + listName + "')/GetItemById(" + itemId + ")";
                return baseService.deleteRequest(url);
            };
            return {
                getAll: getAll,
                addNew: addNew,
                getById: getById,
                update: update,
                remove: remove
            };
        }]);
})();