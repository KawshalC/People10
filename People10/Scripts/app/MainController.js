people10App.controller('MainController', function ($scope, dataFetcherService) {
    $scope.productList = [];
    $scope.selectCategory = function (category) {
        $scope.selectedCategory = category.Name;
        $scope.productList = [];
        dataFetcherService.dataFetcher({ url: 'People10/GetProductList', params: { categoryId: category.ID }}).then(function (productList) {
            $scope.productList = productList;
        });
    };
    $scope.getCategoryData = function () {
        dataFetcherService.dataFetcher({ url: 'People10/GetCategoryList' }).then(function (categoryList) {
            $scope.categoryList = categoryList;
        });
    };
});