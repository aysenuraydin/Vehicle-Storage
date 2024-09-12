import { Component, OnInit } from '@angular/core';
import { ColorService } from '../../color.service';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrl: './footer.component.css'
})
export class FooterComponent implements OnInit {
  bgColor: string = '';

  constructor(private colorService: ColorService) {}

  ngOnInit(): void {
    this.colorService.currentColor.subscribe(color => this.bgColor = color);
  }
}
