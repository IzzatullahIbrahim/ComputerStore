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
        public message = 'Laptops Controller Working';
        public laptops;

        constructor(private $http: ng.IHttpService) {
            this.$http.get('/api/laptops').then((response) => {
                this.laptops = response.data;
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
