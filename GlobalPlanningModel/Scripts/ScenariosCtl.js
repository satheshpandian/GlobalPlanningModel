var app = angular.module('app', ['ngTouch', 'ui.grid']);

app.controller('MainCtrl', ['$scope', '$http', '$interval', 'uiGridConstants', function ($scope, $http, $interval, uiGridConstants) {

    $scope.gridOptions = {
        enableFiltering: true,
        useExternalFiltering: true,
        columnDefs: [
            { name: 'ScenarioID', enableFiltering: false },
            { name: 'Name' },
            { name: 'Surname' },
            { name: 'Forename' },    
            { name: 'UserID' },    
            { name: 'SampleDate' },
            { name: 'CreationDate' },
            { name: 'NumMonths' },
            { name: 'MarketID' },
            { name: 'NetworkLayerID' }
        ],
        data: [],
        onRegisterApi: function (gridApi) {
            $scope.gridApi = gridApi;
            $scope.gridApi.core.on.filterChanged($scope, function () {
                var grid = this.grid;
                // filter not implemented
            });
        }
    };

    $http.get('/Scenarios/GetAllScenarios')
        .then(function (response) {
            var data = response.data;
                $scope.gridOptions.data = response.data;

            data.forEach(function addDates(row, index) {
                //to do date format
            });
        });
}]);