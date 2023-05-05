import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ParametersService {

  view: boolean = true;
  viewInput(value: boolean) {
    this.view = value
  }
  viewOutput() {
    return this.view
  }
}
