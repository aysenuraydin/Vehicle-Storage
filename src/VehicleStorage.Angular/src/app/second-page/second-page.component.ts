
import { Component, OnInit } from '@angular/core';
import { Products } from '../models/product';
import { ProductService } from '../product.service';

@Component({
  selector: 'app-second-page',
  templateUrl: './second-page.component.html',
  styleUrls: ['./second-page.component.css']
})
export class SecondPageComponent implements OnInit {
  products: Products[] = [];
  selectedProduct: Products | null = null;
  title :string = "Grid";
  colors: string[] = ['red', 'blue', 'green', 'yellow'];
  currentColor: string = '';

  constructor(private productService: ProductService) {}

  ngOnInit(): void {
    this.products = this.productService.getProducts();
    // Tarayıcıda daha önce seçilen rengi yükle
    const savedColor = localStorage.getItem('backgroundColor');
    if (savedColor) {
      this.currentColor = savedColor;
    }
  }

  changeColor(color: string): void {
    this.currentColor = color;
    // Seçilen rengi tarayıcıda sakla
    localStorage.setItem('backgroundColor', color);
  }
  handleFormSubmit(product: Products): void {
    if (this.selectedProduct) {
      this.productService.updateProduct(product);
      this.selectedProduct = null;
    } else {
      product.id = this.products.length + 1;
      this.productService.saveProduct(product);
    }
    this.products = this.productService.getProducts(); // Refresh the list
  }

  handleFormReset(): void {
    this.selectedProduct = null;
  }

  handleSelectProduct(product: Products): void {
    this.selectedProduct = product;
    console.warn("edit tıklandı");
  }

  handleDeleteProduct(product: Products): void {
    this.productService.deleteProduct(product);
    this.products = this.products.filter(p => p.id !== product.id);
  }
}
