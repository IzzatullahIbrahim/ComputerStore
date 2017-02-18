namespace ComputerStore.Controllers {

    export class HomeController {
        public message = 'Hello from the home page!';
    }

    export class ProductsController {
        public message = 'Products Controller Working';
        public products;

        constructor(private $http: ng.IHttpService) {
            this.$http.get('/api/products').then((response) => {
                this.products = response.data;
            })
        }
    }

    export class LaptopsController {
        public message = 'Laptops Controller is working';
        public message2 = 'Laptop Controller is working'
        public laptops;

        constructor(private $http: ng.IHttpService) {
            this.$http.get('/api/laptops').then((response) => {
                this.laptops = response.data;
            })
        }
    }

    export class AddLaptopController {
        public message = 'Add a Laptop Controller is working'
        public laptop;

        constructor(private $http: ng.IHttpService, private $state: ng.ui.IStateService) {

        }

        public addLaptop() {
            this.$http.post('api/laptops', this.laptop).then((response) => {
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
