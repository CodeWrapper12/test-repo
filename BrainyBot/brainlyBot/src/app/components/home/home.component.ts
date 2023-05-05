import { Component, HostListener } from '@angular/core';
import { ParametersService } from 'src/app/services/parameters.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  constructor(private param: ParametersService) {
    this.checkScreenWidth();
    window.onresize = () => {
      this.checkScreenWidth()
    }
  }
  view = this.param.viewOutput();
  @HostListener('window:keyup.space', ['$event'])
  onSpace(event: any) {
    console.log("entered", event);
    this.view = false
    this.param.viewInput(this.view)
  }
  checkScreenWidth() {
    if (window.innerWidth <= 1500) {
      this.view = false
    }
    else {
      this.view = this.param.viewOutput();
    }
  }
}


