people10App.service('dataFetcherService', ['$q', '$http', '$log', function ($q, $http, $log) {
    var baseApiURl = "../api/";
    var categoryFetcher = function () { };
    var productFetcher = function () { };
    var dataFetcher = function (config) {
        var deferred = $q.defer();
        var requestObject = {
            url: baseApiURl + config.url,
            method: config.type ? config.type : "GET",
            params: config.params ? config.params : {},
            dataType: "json",
            headers: {
                'Content-Type': "application/json"
            }
        };
        $http(requestObject)
        .success(function (data) {
            deferred.resolve(data);
        }).error(function (msg, code) {
            $log.error(msg, code);
            deferred.reject(msg);
        });
        return deferred.promise;

    };
    return {
        dataFetcher: dataFetcher
    }
}]);