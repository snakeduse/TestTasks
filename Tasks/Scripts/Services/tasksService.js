(function () {
    'use strict';

    var heroesService = angular.module('tasksService', ['ngResource']);
    heroesService.factory('Tasks', ['$resource',
        function ($resource) {
            return $resource('/api/tasks', {}, {
                getAll: { method: 'GET', params: {}, isArray: true }
            });
        }
    ]);
})();