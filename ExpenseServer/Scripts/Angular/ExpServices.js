app.service('ExpDataService', function (  $http ) {
    this.get = function (target, callback) {
        return $http.get(target).then(function (response) {
                callback(response.data);
            });
        }

   
});

// @*<script >
//    var app = angular.module("expenseApp", []);



//app.controller("expCtlr", function ($scope, $http) {

//    $scope.targetString = {
//        hostServer: "http://localhost",
//        expCtlr: "/Exp/",
//        get: function (thing) {
//            return hostServer + expCtlr + thing;
//        }

//    };
//    $scope.ExpenseRecordModel =
//      {
//          "id": 4,
//          "OwnerId": "2c0b1b7d-17ce-431a-b46e-3bc197caf995",
//          "ExpDate": "2016-01-29T00:00:00",
//          "Description": "string",
//          "Amount": 1000,
//          "Posted": "2016-01-29T00:00:00",
//          "PersonalCategoryId": 1,
//          "CategoriesId": 5
//      };
//    $scope.ExpUserModel =
//        {
//            "id": "2c0b1b7d-17ce-431a-b46e-3bc197caf995",
//            "email": "test@test.com",
//            "password": "password",
//            "FirstName": "test",
//            "LastName": "account",
//            "OrgId": 1
//        };
//    $scope.ExpCategoryModel =
//        {
//            "id": 0,
//            "Name": "string",
//            "SortOrder": 0
//        };
//    $scope.ExpPersonalCategoryModel =
//        {
//            "id": 2,
//            "Name": "Default",
//            "OwnerId": "2c0b1b7d-17ce-431a-b46e-3bc197caf995",
//            "SortOrder": 1
//        };
//    $scope.ExpPersonalCategories = [];
//    $scope.ExpCategories = [];
//    $scope.userList = [];
//    $scope.CurrentExpList = [];
//    $scope.getCats = function () {
//        return $http.get('http://localhost:64107/Exp').then(function (response) {
//            $scope.ExpCategories = response.data;
//        });
//    };
//    $scope.getUserList = function () {
//        return $http.get('http://localhost:64107/Exp/GetUsers').then(function (response) {
//            $scope.userList = response.data;
//        });
//    };
//    $scope.getExpPersonalCategories = function (userid) {
//        return $http.get('http://localhost:64107/Exp/GetPersonalCategories/' + userid).then(function (response) {
//            $scope.ExpPersonalCategories = response.data;
//        });
//    };
//    $scope.getCurrentExpList = function (userid) {
//        return $http.get('http://localhost:64107/Exp/ListExpenesForUser/' + userid).then(function (response) {
//            $scope.CurrentExpList = response.data;
//        });
//    };
//    $scope.ChangeUser = function (userid) {
//        $scope.getExpPersonalCategories(userid);
//        $scope.getCurrentExpList(userid);
//    };

//    $scope.getUserList();
//    $scope.getCats();
       
//});  