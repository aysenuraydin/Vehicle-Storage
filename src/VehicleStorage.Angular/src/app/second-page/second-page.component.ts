
import { Component, OnInit } from '@angular/core';
import { Products } from '../models/product';
import { ProductService } from '../product.service';
import { ColorService } from '../color.service';

@Component({
  selector: 'app-second-page',
  templateUrl: './second-page.component.html',
  styleUrls: ['./second-page.component.css']
})
export class SecondPageComponent implements OnInit {
  products: Products[] = [];
  selectedProduct: Products | null = null;
  title :string = "Grid";
  colors: string[] = ['#99B6B7', '#E9A290', '#B46A6B', '#556C56', '#BEBEBE', '#CDE5EC', '#E9E788', '#C6B9D1', '#E2AEB3'];
  currentColor: string = '';

  constructor(private productService: ProductService, private colorService: ColorService) {}

  ngOnInit(): void {
    this.products = this.productService.getProducts();
    const savedColor = localStorage.getItem('backgroundColor');
    if (savedColor) {
      this.currentColor = savedColor;
      this.colorService.changeColor(savedColor);
    }
  }

  changeColor(color: string): void {
    this.currentColor = color;
    this.colorService.changeColor(color);
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
    this.products = this.productService.getProducts();
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
