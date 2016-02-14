(function () {
    'use strict';

    var typesService = angular.module('typesService', ['ngResource']);
    typesService.factory('Types', ['$resource',
        function ($resource) {
            return $resource('/api/types', {}, {
                getAll: { method: 'GET', params: {}, isArray: true }
            });
        }
    ]);
})();