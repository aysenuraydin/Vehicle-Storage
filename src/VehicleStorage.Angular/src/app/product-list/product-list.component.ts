import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Products } from '../models/product';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent {
  @Input() products: Products[] = [];
  @Output() selectProduct = new EventEmitter<Products>();
  @Output() deleteProduct = new EventEmitter<Products>();

  onSelectProduct(product: Products): void {
    this.selectProduct.emit(product);
  }

  onDeleteProduct(product: Products): void {
    this.deleteProduct.emit(product);
  }
}
