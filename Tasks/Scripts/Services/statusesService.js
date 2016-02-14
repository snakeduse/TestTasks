(function () {
    'use strict';

    var statusesService = angular.module('statusesService', ['ngResource']);
    statusesService.factory('Statuses', ['$resource',
        function ($resource) {
            return $resource('/api/statuses', {}, {
                getAll: { method: 'GET', params: {}, isArray: true }
            });
        }
    ]);
})();