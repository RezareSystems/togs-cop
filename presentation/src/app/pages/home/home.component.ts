import { Component } from '@angular/core';

@Component({
  templateUrl: 'home.component.html',
  styleUrls: [ './home.component.scss' ]
})

export class HomeComponent {
  staff: any[];

  constructor() {
    this.staff = [
      {
        workFlowMaxId: 1,
        name: 'Sean Coon'
      },
      {
        workFlowMaxId: 2,
        name: 'Robert Larkins'
      }
    ]
  }
}
