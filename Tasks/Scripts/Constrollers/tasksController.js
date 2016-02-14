(function () {
    'use strict';

    angular
        .module('tasksApp')
        .controller('tasksController', tasksController);

    tasksController.$inject = ['$scope', 'Tasks', 'Statuses'];

    function tasksController($scope, Tasks, Statuses) {

        $scope.Tasks = Tasks.getAll();
        $scope.Statuses = Statuses.getAll();

        $scope.getStatusName = (function (statusId) {
            var status = $scope.Statuses[statusId];
            if (status){
                return status.Name;
            }

            return null;
        });
    }
})();