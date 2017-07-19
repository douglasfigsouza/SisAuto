app.service("SisAutoService", function ($http) {
    this.getAllCitiesIdStates = function (id) {
        debugger;
        var url = "Clientes/getAllCitiesIdStates/"+id;
        return $http.get(url);
    };
});