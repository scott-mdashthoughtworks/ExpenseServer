


app.controller("expCtlr", function ($scope, ExpDataService) {
    $scope.loading = false;
    $scope.targetString = {
        hostServer: "http://localhost:64107",
        expCtlr: "/Exp/",
        get : function(thing)
        {
            return $scope.targetString.hostServer +
                $scope.targetString.expCtlr +
                thing;
        }

    };
    $scope.ExpenseRecordModel =
      {
          "id": 4,
          "OwnerId": "2c0b1b7d-17ce-431a-b46e-3bc197caf995",
          "ExpDate": "2016-01-29T00:00:00",
          "Description": "string",
          "Amount": 1000,
          "Posted": "2016-01-29T00:00:00",
          "PersonalCategoryId": 1,
          "CategoriesId": 5
      };
    $scope.ExpUserModel =
        {
            "id": "2c0b1b7d-17ce-431a-b46e-3bc197caf995",
            "email": "test@test.com",
            "password": "password",
            "FirstName": "test",
            "LastName": "account",
            "OrgId": 1
        };
    $scope.ExpCategoryModel =
        {
            "id": 0,
            "Name": "string",
            "SortOrder": 0
        };
    $scope.ExpPersonalCategoryModel =
        {
            "id": 2,
            "Name": "Default",
            "OwnerId": "2c0b1b7d-17ce-431a-b46e-3bc197caf995",
            "SortOrder": 1
        };
    $scope.ExpPersonalCategories = [];
    $scope.ExpCategories = [];

    ExpDataService.get(
        $scope.targetString.get("GetCategories"),
        function (data) {
            $scope.ExpCategories = data;
            $scope.loading = false;
        });
});