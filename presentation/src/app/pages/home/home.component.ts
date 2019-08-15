import { Component } from '@angular/core';
import CustomStore from 'devextreme/data/custom_store'
import { StaffApiService } from '../../modules/api/staff-api.service';
import { appInitializerFactory } from '@angular/platform-browser/src/browser/server-transition';

@Component({
  templateUrl: 'home.component.html',
  styleUrls: [ './home.component.scss' ]
})
export class HomeComponent {
  store: CustomStore;
  startDate: Date = new Date();
  endDate: Date = new Date();

  constructor(staffApi: StaffApiService) {
    this.store = new CustomStore({
      load: function(loadOptions: any) {
        return staffApi.getAll()
          .then((data: any) => {
            return {
              data: data
            }
          })
          .catch(error => { throw 'Data Loading Error' });
      }
    });
  }
}
