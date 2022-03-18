import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';
import { ResponseService } from '../ResponseService';
import { addMealPlane, updateMealPlane } from './Model/mealPlane';

@Injectable({
  providedIn: 'root'
})
export class MealService {
 url:string="https://localhost:5001/";
  constructor(private httpClient:HttpClient){ }
  addMealPlane(addMealPlane :addMealPlane)
  {
    return   this.httpClient.post<ResponseService>(this.url+'/Meal/AddMeal',addMealPlane).
    pipe(map((Res:ResponseService)=>{
      return  Res
    }))
  }
  getMealPlane()
  {
    return   this.httpClient.get<ResponseService>(this.url+'/Meal/GetMeal').
    pipe(map((Res:ResponseService)=>{
      return  Res
    }))
  }
  updateMealPlane(updateMealPlane :updateMealPlane)
  {
    return   this.httpClient.put<ResponseService>(this.url+'/Meal/AddMeal',updateMealPlane).
    pipe(map((Res:ResponseService)=>{
      return  Res
    }))
  }
  removeMealPlane(id :number)
  {
    return   this.httpClient.delete<ResponseService>(this.url+'/Meal/DeleteMeal/'+id).
    pipe(map((Res:ResponseService)=>{
      return  Res
    }))
  }
  addMealPlanetype(addMealPlane :addMealPlane)
  {
    return   this.httpClient.post<ResponseService>(this.url+'/Meal/AddMeal',addMealPlane).
    pipe(map((Res:ResponseService)=>{
      return  Res
    }))
  }
  getMealPlaneType()
  {
    return   this.httpClient.get<ResponseService>(this.url+'/Meal/GetMeal').
    pipe(map((Res:ResponseService)=>{
      return  Res
    }))
  }
  updateMealPlaneType(updateMealPlane :updateMealPlane)
  {
    return   this.httpClient.put<ResponseService>(this.url+'/Meal/AddMeal',updateMealPlane).
    pipe(map((Res:ResponseService)=>{
      return  Res
    }))
  }
  removeMealPlaneType(id :number)
  {
    return   this.httpClient.delete<ResponseService>(this.url+'/Meal/DeleteMeal/'+id).
    pipe(map((Res:ResponseService)=>{
      return  Res
    }))
  }
}
