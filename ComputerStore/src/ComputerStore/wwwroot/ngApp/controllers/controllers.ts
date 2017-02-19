namespace ComputerStore.Controllers {

    export class HomeController {
        public message = 'Hello from the home page!';
    }

    export class CategoriesController {
        public message = 'Categories Controller Working, or is it?';
        public categories;

        constructor(private $http: ng.IHttpService) {
            this.$http.get('/api/categories').then((response) => {
                this.categories = response.data;
            })
        }
    }

    export class CategoryController {
        public message = 'Category Controller is Working, or is it?';
        public category;

        constructor(private $http: ng.IHttpService, private $stateParams: ng.ui.IStateParamsService) {
            let cId = this.$stateParams['id'];
            console.log(cId);

            this.$http.get('/api/categories/' + cId).then((response) => {
                this.category = response.data;
            })
        }
    }

    //export class LaptopsController {
    //    public message = 'Laptops Controller is working';
    //    public laptops;

    //    constructor(private $http: ng.IHttpService, private $stateParams: ng.ui.IStateParamsService) {
    //        let cId = this.$stateParams['id'];

    //        this.$http.get('/api/categories/' + cId).then((response) => {
    //            this.laptops = response.data;
    //        })
    //    }
    //}

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
