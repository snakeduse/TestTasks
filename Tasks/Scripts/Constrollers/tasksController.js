(function () {
    'use strict';

    angular
        .module('tasksApp')
        .controller('tasksController', tasksController);

    tasksController.$inject = ['$scope', 'Tasks', 'Statuses', 'Types'];

    function tasksController($scope, Tasks, Statuses, Types) {
        $scope.searchItem = '';     // set the default search/filter term

        $scope.Tasks = Tasks.getAll();
        $scope.Statuses = Statuses.getAll();
        $scope.Types = Types.getAll();

        var getElementName = (function (elements, id) {
            var element = elements.find(function (element) { return element.Id == id });

            if (element) {
                return element.Name;
            }

            return null;
        });

        $scope.getStatusName = (function (statusId) {
            var name = getElementName($scope.Statuses, statusId);
            return name;
        });

        $scope.getTypeName = (function (typeId) {
            var name = getElementName($scope.Types, typeId);
            return name;
        });

        var isSearchItemExists = (function (string, substring) {
            return string.toLowerCase().indexOf($scope.searchItem.toLowerCase()) > -1;
        });

        $scope.searchTask = (function (task) {
            var statusName = $scope.getStatusName(task.Status),
                typeName = $scope.getTypeName(task.Type);

            return isSearchItemExists(task.Name)||
                isSearchItemExists(task.CreateDate) ||
                isSearchItemExists(task.EndDate) ||
                isSearchItemExists(task.StatusLastEdit) ||
                isSearchItemExists(statusName) ||
                isSearchItemExists(typeName);
        });
    }
})();