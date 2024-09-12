import { Component } from '@angular/core';
import { ColorService } from '../../color.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css'
})
export class NavbarComponent {
  bgColor: string = '';

  constructor(private colorService: ColorService) {}

  ngOnInit(): void {
    this.colorService.currentColor.subscribe(color => this.bgColor = color);
  }
}
