import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MealComponent } from './Meal.component';
import { AddMealPlaneComponent } from './AddMealPlane/AddMealPlane.component';
import { ListMealPlaneComonentComponent } from './ListMealPlaneComonent/ListMealPlaneComonent.component';
import { AppRoutingModule } from '../app-routing.module';

@NgModule({
  imports: [
    CommonModule,
    AppRoutingModule
  ],
  declarations: [
    MealComponent,
    AddMealPlaneComponent,
    ListMealPlaneComonentComponent
  ],
  exports:[
    MealComponent
  ]

})
export class MealModule { }
