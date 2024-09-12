// import { Injectable } from '@angular/core';
// import { Model, Products } from './models/product';

// @Injectable({
//   providedIn: 'root'
// })
// export class ProductService {

//   model = new Model();

//   getProducts() {
//     return this.model.products;
//   }

//   getProductById(id: number) {
//     return this.model.products.find(i=>i.id==id);
//   }

//   saveProduct(product: Products) {
//   //    if(product.id==0)
//   //    {
//   //      product.id = this.getProducts().length+1;
//   //      this.model.products.push(product);
//   //    }
//   //    else {
//   //      const existingProduct = this.getProductById(product.id);
//   //      if (existingProduct) {
//   //        existingProduct.name = product.name;
//   //        existingProduct.price = product.price;
//   //        existingProduct.isActive = product.isActive;
//   //    }
//   //  }
//   this.model.products.push(product);
//   }

//   deleteProduct(product: Products) {
//     this.model.products = this.model.products.filter(p=>p!==product);

// }
// }

import { Injectable } from '@angular/core';
import { Model, Products } from './models/product';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  private products: Products[] = [];
  model = new Model();
  getProducts(): Products[] {
    //  return this.products;
   return this.model.products;
  }

  getProductById(id: number): Products | undefined {
    // return this.products.find(p => p.id === id);
     return this.model.products.find(p => p.id === id);
  }

  saveProduct(product: Products): void {
    //  this.products.push(product);
     this.model.products.push(product);
  }

  updateProduct(product: Products): void {
    const existingProduct = this.getProductById(product.id);
    if (existingProduct) {
      existingProduct.name = product.name;
      existingProduct.price = product.price;
      existingProduct.isActive = product.isActive;
    }
  }

  deleteProduct(product: Products): void {
   this.products = this.model.products.filter(p => p.id !== product.id);
  //  this.products = this.products.filter(p => p.id !== product.id);
  }
}

