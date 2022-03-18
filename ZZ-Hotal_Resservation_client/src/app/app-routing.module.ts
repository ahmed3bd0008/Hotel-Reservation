import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddMealPlaneComponent } from './Meal/AddMealPlane/AddMealPlane.component';
import { MealComponent } from './Meal/Meal.component';
import { UpdateMealPlaneComponent } from './Meal/UpdateMealPlane/UpdateMealPlane.component';

const routes: Routes = [
  {path:"",component:AddMealPlaneComponent,
  children:[
             {path:"update",component:UpdateMealPlaneComponent}
  ]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
