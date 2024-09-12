import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router";
import { CommonModule } from '@angular/common';
import { FooterComponent } from "./footer/footer.component";
import { NavbarComponent } from "./navbar/navbar.component";
import { SidebarComponent } from "./sidebar/sidebar.component";
import { FirstLayoutComponent } from './first-layout/first-layout.component';
import { SecondLayoutComponent } from './second-layout/second-layout.component';

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild([])
  ],
  exports: [
    FirstLayoutComponent,
    SecondLayoutComponent
  ],
  declarations: [
    FooterComponent,
    NavbarComponent,
    SidebarComponent,
    FirstLayoutComponent,
    SecondLayoutComponent
  ]
})
export class LayoutModule { }
