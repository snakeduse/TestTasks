(function () {
    'use strict';

    angular
        .module('tasksApp')
        .controller('tasksController', tasksController);

    tasksController.$inject = ['$scope', 'Tasks'];

    function tasksController($scope, Tasks, $mdDialog) {

        $scope.Tasks = Tasks.getAll();        
    }
})();