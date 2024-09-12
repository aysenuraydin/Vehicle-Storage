import { Component, EventEmitter, Input, OnChanges, OnInit, Output, SimpleChanges } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Products } from '../models/product';

@Component({
  selector: 'product-form',
  templateUrl: './product-form.component.html',
  styleUrls: ['./product-form.component.css']
})
export class ProductFormComponent implements OnInit, OnChanges {
  @Input() selectedProduct: Products | null = null;
  @Output() formSubmit = new EventEmitter<Products>();
  @Output() formReset = new EventEmitter<void>();

  productForm: FormGroup;

  constructor(private fb: FormBuilder) {
    this.productForm = this.fb.group({
      name: ['', Validators.required],
      price: [0, Validators.required],
      isActive: [false]
    });
  }

  ngOnInit(): void {
    // İlk yükleme sırasında formun dolması
    if (this.selectedProduct) {
      this.productForm.patchValue(this.selectedProduct);
    }
  }

  ngOnChanges(changes: SimpleChanges): void {
    if (changes['selectedProduct'] && this.selectedProduct) {
      // selectedProduct değiştiğinde formu güncelle
      this.productForm.patchValue(this.selectedProduct);
    }
  }

  onSubmit(): void {
    if (this.productForm.valid) {
      const product: Products = {
        id: this.selectedProduct ? this.selectedProduct.id : 0,
        name: this.productForm.value.name,
        price: this.productForm.value.price,
        isActive: this.productForm.value.isActive
      };
      this.formSubmit.emit(product);
      this.productForm.reset();
    }
  }

  onReset(): void {
    this.productForm.reset();
    this.formReset.emit();
  }
}
