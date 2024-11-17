import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Route,RouterModule } from '@angular/router';
import { LoginComponent } from './login.component';

const routes:Route[] = 
[
  {path:'Login',component:LoginComponent}
];

@NgModule({
  declarations: [
    LoginComponent
  ],
  imports: [
    RouterModule.forChild(routes),
    CommonModule,
  ]
})
export class LoginModule { }
