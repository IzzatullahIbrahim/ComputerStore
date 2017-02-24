namespace ComputerStore.Controllers {

    export class HomeController {
        public message = 'Hello from the home page!';
        public prod1Id = 9014;
        public prod2Id = 9015;
        public prod3Id = 9016;
        public prod4Id = 9017;
        public product1;
        public product2;
        public product3;
        public product4;

        constructor(private $http: ng.IHttpService) {
            this.$http.get('/api/Laptops/' + this.prod1Id).then((response) => {
                this.product1 = response.data;
            })
            this.$http.get('/api/Laptops/' + this.prod2Id).then((response) => {
                this.product2 = response.data;
            })
            this.$http.get('/api/Laptops/' + this.prod3Id).then((response) => {
                this.product3 = response.data;
            })
            this.$http.get('/api/Laptops/' + this.prod4Id).then((response) => {
                this.product4 = response.data;
            })
        }
    }

    export class CategoriesController {
        public message = 'Categories Controller Working, or is it?';
        public categories;

        constructor(private $http: ng.IHttpService, private $state: ng.ui.IStateService) {
            this.$http.get('/api/categories').then((response) => {
                this.categories = response.data;
            })
        }

        public deleteCategory(id: number) {
            this.$http.delete(`/api/categories/` + id).then((response) => {
                this.$state.go('home');
            })
        }
    }

    export class CategoryController {
        public message = 'Category Controller is Working, or is it?';
        public category;

        constructor(private $http: ng.IHttpService, private $stateParams: ng.ui.IStateParamsService) {
            let cId = this.$stateParams['id'];

            this.$http.get('/api/categories/' + cId).then((response) => {
                this.category = response.data;
            })
        }
    }

    export class AddCategoryController {
        public message = 'Add category controller is working';
        public category;

        constructor(private $http: ng.IHttpService, private $state: ng.ui.IStateService) {

        }

        public addCategory() {
            this.$http.post('/api/categories', this.category).then((response) => {
                this.$state.go('home');
            })
        }
    }

    export class EditCategoryController {
        public message = "Edit category controller is working";
        public category;

        constructor(private $http: ng.IHttpService, private $state: ng.ui.IStateService, private $stateParams: ng.ui.IStateParamsService) {
            let cId = this.$stateParams['id'];

            this.$http.get('/api/categories/' + cId).then((response) => {
                this.category = response.data;
            })
        }

        public editCategory() {
            this.$http.post('/api/categories', this.category).then((response) => {
                this.$state.go('home');
            })
        }
    }

    export class LaptopController {
        public message = 'Laptop Controller is working, or is it?';
        public laptop;

        constructor(private $http: ng.IHttpService, private $stateParams: ng.ui.IStateParamsService) {
            let lId = this.$stateParams['id'];

            this.$http.get('/api/laptops/' + lId).then((response) => {
                this.laptop = response.data;
            })
        }
    }

    export class AddLaptopController {
        public message = 'Add a Laptop Controller is working, or is it?';
        public laptop;
        public categories;

        constructor(private $http: ng.IHttpService, private $state: ng.ui.IStateService) {
            this.$http.get('/api/categories').then((response) => {
                this.categories = response.data;
            }) 
        }

        public addLaptop() {
            this.$http.post('/api/laptops', this.laptop).then((response) => {
                this.$state.go('home');
            })
        }
    }

    export class EditLaptopController {
        public message = 'Edit a Laptop Controller is working, or is it?';
        public laptop;

        constructor(private $http: ng.IHttpService, private $state: ng.ui.IStateService, private $stateParams: ng.ui.IStateParamsService) {
            let lId = this.$stateParams['id'];

            this.$http.get('/api/laptops/' + lId).then((response) => {
                this.laptop = response.data;
            })
        }

        public editLaptop() {
            this.$http.post('/api/laptops', this.laptop).then((response) => {
                this.$state.go('home');
            })
        }
    }

    export class DeleteLaptopController {
        public message = 'Delete a Laptop Controller is working, or is it?';
        public laptop;

        constructor(private $http: ng.IHttpService, private $state: ng.ui.IStateService, private $stateParams: ng.ui.IStateParamsService) {
            let lId = this.$stateParams['id'];
            console.log(lId);

            this.$http.get('/api/laptops/' + lId).then((response) => {
                this.laptop = response.data;
            })
        }

        public deleteLaptop(id: number) {
            this.$http.delete(`/api/laptops/` + id).then((response) => {
                this.$state.go('home');
            })
        }
    }

    export class SecretController {
        public secrets;

        constructor($http: ng.IHttpService) {
            $http.get('/api/secrets').then((results) => {
                this.secrets = results.data;
            });
        }
    }

    export class AboutController {
        public message = 'Hello from the about page!';
    }

}
