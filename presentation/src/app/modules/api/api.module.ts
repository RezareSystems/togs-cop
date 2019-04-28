import { NgModule } from '@angular/core'
import { ApiUrlGeneratorService } from './api-url-generator.service';
import { StaffApiService } from './staff-api.service';
import { HttpClientConfigurationService } from './http-client-configuration.service';

@NgModule({
    providers: [
        ApiUrlGeneratorService,
        HttpClientConfigurationService,
        StaffApiService
    ]
})
export class ApiModule { }