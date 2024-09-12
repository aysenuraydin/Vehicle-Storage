// import { Component } from '@angular/core';
// import { Model, Products } from './models/product';
// import { ProductService } from './product.service';
// import { FormBuilder, FormGroup, Validators } from '@angular/forms';

// @Component({
//   selector: 'app-root',
//   templateUrl: './app.component.html',
//   styleUrl: './app.component.css'
// })
// export class AppComponent {
//   productForm: FormGroup;
//     title = 'VehicleStorage Angular';
//     products :Products[] =[];
//     selectedProduct: Products | null = null;

//     constructor(private fb: FormBuilder,private productService:ProductService){
//       this.productForm = this.fb.group({
//         name: ['', Validators.required],
//         price: [0, Validators.required]
//       });
//     }

//     ngOnInit(): void{
//       this.products =this.productService.getProducts();
//     }

//     addProduct2(name: string,price: string,isactive: boolean)
//     {
//       console.log(name,price,isactive)

//        const p = new Products(
//          this.productService.getProducts().length+1,
//          name,
//          Number(price),
//          isactive
//        );
//       this.productService.saveProduct(p);
//     }

//     addProduct(): void {
//       if (this.selectedProduct) {
//         // Ürün güncelleme
//         const updatedProduct: Products = {
//           id: this.selectedProduct.id,
//           name: this.productForm.value.name,
//           price: this.productForm.value.price,
//           isActive: this.productForm.value.isActive
//         };
//         this.productService.saveProduct(updatedProduct);
//         this.selectedProduct = null;
//       } else {
//         // Yeni ürün ekleme
//         const newProduct: Products = {
//           id: this.products.length + 1,
//           name: this.productForm.value.name,
//           price: this.productForm.value.price,
//           isActive: this.productForm.value.isActive
//         };
//         this.productService.saveProduct(newProduct);
//       }

//       this.productForm.reset();
//     }

//     onSelectProduct(product: Products) {
//       this.selectedProduct = product;
//       this.productForm.patchValue({
//         name: product.name,
//         price: product.price
//       });
//     }

//     deleteProduct(product: Products) {
//       this.productService.deleteProduct(product);
//     }
// }




import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ProductService } from './product.service';
import { Products } from './models/product';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  /*
  productForm: FormGroup;
  title = 'VehicleStorage Angular';
  products: Products[] = [];
  selectedProduct: Products | null = null;

  constructor(private fb: FormBuilder, private productService: ProductService) {
    this.productForm = this.fb.group({
      name: ['', Validators.required],
      price: [0, Validators.required],
      isActive: [false]
    });
  }

  ngOnInit(): void {
    this.products = this.productService.getProducts();
  }

  onSubmit(): void {
    if (this.selectedProduct) {
      // Ürün güncelleme işlemi
      const updatedProduct: Products = {
        id: this.selectedProduct.id,
        name: this.productForm.value.name,
        price: this.productForm.value.price,
        isActive: this.productForm.value.isActive
      };
      this.productService.updateProduct(updatedProduct);
      this.selectedProduct = null;  // Düzenleme işlemi bitti
    } else {
      // Yeni ürün ekleme işlemi
      const newProduct: Products = {
        id: this.products.length + 1,
        name: this.productForm.value.name,
        price: this.productForm.value.price,
        isActive: this.productForm.value.isActive
      };
      this.productService.saveProduct(newProduct);
    }

    this.productForm.reset();  // Formu sıfırlama
  }

  onSelectProduct(product: Products): void {
    // Seçilen ürünü düzenleme için formu doldur
    this.selectedProduct = product;
    this.productForm.patchValue({
      name: product.name,
      price: product.price,
      isActive: product.isActive
    });
  }

  deleteProduct(product: Products): void {
    this.productService.deleteProduct(product);
    this.products = this.products.filter(p => p.id !== product.id);
  }
    */
}
