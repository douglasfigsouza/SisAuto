app.controller("SisAutoCtrl", function ($scope, SisAutoService) {
    // função que preenche select cidades clientes
    $scope.getAllCitiesState = function (id) {
        var servCall = SisAutoService.getAllCitiesIdStates(id);
        servCall.then(function (cities) {
            $scope.lstCitiesClientes = cities.data;
        }, function (error) {
            alert("Ops! algo deu errado");
        });
    };

    //função que preenche combo mecânicos
    $scope.getAllCitiesIdStatesMecanicos = function (id)
    {
        var servCall = SisAutoService.getAllCitiesIdStates(id);
        servCall.then(function (cities) {
            $scope.lstCitiesMecs = cities.data;
        }, function (error) {
            alert("Ops! algo deu errado");
        });
    }
    $scope.getIdCitie = function (id) {
        $scope.CidadeId = id;
    };
});