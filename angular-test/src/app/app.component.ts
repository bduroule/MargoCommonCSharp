import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'angular-test';
  index: number = 0;

  IncrementIndex() {
    console.log(this.index);
    this.index++;
  }
}
