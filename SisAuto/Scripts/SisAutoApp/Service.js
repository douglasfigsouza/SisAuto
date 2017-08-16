app.service("SisAutoService", function ($http) {
    this.getAllCitiesIdStates = function (id) {
        var url = "getAllCitiesIdStates/" + id;
        return $http.get(url);
    };
});