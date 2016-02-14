﻿(function () {
    'use strict';

    angular
        .module('tasksApp')
        .controller('tasksController', tasksController);

    tasksController.$inject = ['$scope', 'Tasks', 'Statuses', 'Types'];

    function tasksController($scope, Tasks, Statuses, Types) {
        $scope.searchTasks= '';     // set the default search/filter term

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
    }
})();