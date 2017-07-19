app.controller("SisAutoCtrl", function ($scope, SisAutoService) {
    $scope.getAllCitiesState = function (id) {
        var servCall = SisAutoService.getAllCitiesIdStates(id);
        servCall.then(function (cities) {
            $scope.lstCities = cities.data;
        }, function (error) {
            alert("Ops! algo deu errado");
        });
    };
    $scope.getIdCitie = function (id) {
        $scope.CidadeId = id;
    };
});