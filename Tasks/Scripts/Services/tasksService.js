(function () {
    'use strict';

    var tasksService = angular.module('tasksService', ['ngResource']);
    tasksService.factory('Tasks', ['$resource',
        function ($resource) {
            return $resource('/api/tasks', {}, {
                getAll: { method: 'GET', params: {}, isArray: true }
            });
        }
    ]);
})();