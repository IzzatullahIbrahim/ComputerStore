namespace ComputerStore {

    angular.module('ComputerStore', ['ui.router', 'ngResource', 'ui.bootstrap']).config((
        $stateProvider: ng.ui.IStateProvider,
        $urlRouterProvider: ng.ui.IUrlRouterProvider,
        $locationProvider: ng.ILocationProvider
    ) => {
        // Define routes
        $stateProvider
            .state('home', {
                url: '/',
                templateUrl: '/ngApp/views/home.html',
                controller: ComputerStore.Controllers.HomeController,
                controllerAs: 'controller'
            })
            .state('secret', {
                url: '/secret',
                templateUrl: '/ngApp/views/secret.html',
                controller: ComputerStore.Controllers.SecretController,
                controllerAs: 'controller'
            })
            .state('login', {
                url: '/login',
                templateUrl: '/ngApp/views/login.html',
                controller: ComputerStore.Controllers.LoginController,
                controllerAs: 'controller'
            })
            .state('register', {
                url: '/register',
                templateUrl: '/ngApp/views/register.html',
                controller: ComputerStore.Controllers.RegisterController,
                controllerAs: 'controller'
            })
            .state('externalRegister', {
                url: '/externalRegister',
                templateUrl: '/ngApp/views/externalRegister.html',
                controller: ComputerStore.Controllers.ExternalRegisterController,
                controllerAs: 'controller'
            }) 
            .state('about', {
                url: '/about',
                templateUrl: '/ngApp/views/about.html',
                controller: ComputerStore.Controllers.AboutController,
                controllerAs: 'controller'
            })
            .state('categories', {
                url: '/categories',
                templateUrl: '/ngApp/views/categories.html',
                controller: ComputerStore.Controllers.CategoriesController,
                controllerAs: 'controller'
            })
            .state('category', {
                url: '/categories/:id',
                templateUrl: '/ngApp/views/category.html',
                controller: ComputerStore.Controllers.CategoryController,
                controllerAs: 'controller'
            })
            .state('laptop', {
                url: '/laptop/:id',
                templateUrl: '/ngApp/views/laptop.html',
                controller: ComputerStore.Controllers.LaptopController,
                controllerAs: 'controller'
            })
            .state('addLaptop', {
                url: '/addLaptop',
                templateUrl: '/ngApp/views/addLaptop.html',
                controller: ComputerStore.Controllers.AddLaptopController,
                controllerAs: 'controller'
            })
            .state('editLaptop', {
                url: '/editLaptop/:id',
                templateUrl: '/ngApp/views/editLaptop.html',
                controller: ComputerStore.Controllers.EditLaptopController,
                controllerAs: 'controller'
            })
            .state('deleteLaptop', {
                url: '/deleteLaptop/:id',
                templateUrl: '/ngApp/views/deleteLaptop.html',
                controller: ComputerStore.Controllers.DeleteLaptopController,
                controllerAs: 'controller'
            })
            .state('notFound', {
                url: '/notFound',
                templateUrl: '/ngApp/views/notFound.html'
            });

        // Handle request for non-existent route
        $urlRouterProvider.otherwise('/notFound');

        // Enable HTML5 navigation
        $locationProvider.html5Mode(true);
    });

    
    angular.module('ComputerStore').factory('authInterceptor', (
        $q: ng.IQService,
        $window: ng.IWindowService,
        $location: ng.ILocationService
    ) =>
        ({
            request: function (config) {
                config.headers = config.headers || {};
                config.headers['X-Requested-With'] = 'XMLHttpRequest';
                return config;
            },
            responseError: function (rejection) {
                if (rejection.status === 401 || rejection.status === 403) {
                    $location.path('/login');
                }
                return $q.reject(rejection);
            }
        })
    );

    angular.module('ComputerStore').config(function ($httpProvider) {
        $httpProvider.interceptors.push('authInterceptor');
    });

    

}
