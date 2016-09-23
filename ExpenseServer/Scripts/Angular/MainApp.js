


app.controller("expCtlr", function ($scope, ExpDataService) {
    $scope.loading = false;
    $scope.targetString = {
        hostServer: "http://localhost:64107",
        expCtlr: "/Exp/",
        get: function (thing) {
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
            "Name": "Undefined",
            "SortOrder": 0
        };
    $scope.ExpPersonalCategoryModel =
        {
            "id": 2,
            "Name": "Default",
            "OwnerId": "2c0b1b7d-17ce-431a-b46e-3bc197caf995",
            "SortOrder": 1
        };
    $scope.expList = {
        expdata: []

    }
    $scope.currentExp = {};
    $scope.cdate = "";
    $scope.loadNewExp = function () {
        $("#expBlock").toggle();
        $scope.currentExp = {
            "id": 0,
            "OwnerId": $scope.selectedUser.id,
            "ExpDate": $scope.cdate,
            "Description": " ",
            "Amount": 0,
            "Posted": "2016-01-29T00:00:00",
            "PersonalCategoryId": 1,
            "CatId": 1
        }
        $scope.Mode = 'New';
        $scope.selectedCat = $scope.getCategories(1);
    }
    $scope.SaveExp = function () {

        $scope.currentExp.CatId = $scope.selectedCat.id;
        $scope.cdate = $scope.currentExp.ExpDate;
        ExpDataService.post(
            $scope.targetString.get("AddExpenseRecord"),
            $scope.currentExp,
            $scope.CompleteExpSave,
            $scope.errorBack
            );


    }
    $scope.CompleteExpSave = function (response) {
        $scope.expList.expdata.push($scope.currentExp);
        $("#expBlock").toggle();

    }
    $scope.Mode = 'New';
    $scope.errorBack = function (response) {
        alert("Data: " + data +
                    "<hr />status: " + status +
                    "<hr />headers: " + header +
                    "<hr />config: " + config);
    };



    $scope.getCategories = function (item) {
        if ($scope.ExpCategories) {
            for (a = 0; a < $scope.ExpCategories.length; a++) {
                if ($scope.ExpCategories[a].id == item) {
                    return $scope.ExpCategories[a];
                }
            }
        }
        return $scope.ExpCategoryModel;
    }
    $scope.selectedCat = $scope.getCategories(1);
    $scope.changeCurrentExpCat = function () {
        $scope.currentExp.CategoriesId = $scope.selectedCat.id;
    }
    $scope.ExpPersonalCategories = [];
    $scope.ExpCategories = [];
    $scope.expUsers = [];
    $scope.selectedUser = $scope.ExpUserModel;
    $scope.displayUserItem = function (item) {
        return item.FirstName + " " + item.LastName;
    }

    $scope.toggleUserSelection = function () {
        $('#selectuserbutton').toggle();
        $('#selectuserthing').toggle();
    };
    $scope.gridGetCategory = function (item) {
        return $scope.getCategories(item.row.entity.CategoriesId).Name;
    }
    $scope.changeUser = function () {
        $scope.toggleUserSelection();
        ExpDataService.get($scope.targetString.get("GetPersonalCategories/" + $scope.selectedUser.id), function (data) {
            $scope.ExpPersonalCategories = data;
        });
        ExpDataService.get($scope.targetString.get("ListExpenesForUser/" + $scope.selectedUser.id), function (data) {
            $scope.expList.expdata = data;

            $scope.expGridOptions.data = $scope.expList.expdata;
        });

    };


    ExpDataService.get($scope.targetString.get("GetUsers"), function (data) {
        $scope.expUsers = data;
        $scope.loadingUsers = false;
    });
    ExpDataService.get(
        $scope.targetString.get("GetCategories"),
        function (data) {
            $scope.ExpCategories = data;
            $scope.loading = false;
        });

    $scope.expGridOptions = {
        enableSorting: true,
        paginationPageSizes: [25, 50, 75],
        paginationPageSize: 25,
        columnDefs: [
          {
              name: 'Date',
              field: 'ExpDate',
              type: 'date',
              cellFilter: 'date:"yyyy-MM-dd"'
          },
          {
              name: 'Category',
              cellTemplate: '<div class="ui-grid-cell-contents">{{grid.appScope.gridGetCategory( this )}} </div>'
          },
          {
              name: 'Description',
              field: 'Description',
              enableCellEdit: false
          },
          {
              name: 'Amount',
              field: 'Amount',
              enableCellEdit: false
          }
        ],
        data: $scope.expList.expdata

    };
});

