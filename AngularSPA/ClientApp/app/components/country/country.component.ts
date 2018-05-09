import { Component, OnInit } from '@angular/core';
import { HttpService } from '../../shared/services/http.service';

@Component({
    selector: 'country',
    templateUrl: './country.component.html'
})
export class CountryComponent implements OnInit{

    private countries: any[] = [];

    constructor(private httpService: HttpService) {

    }

    ngOnInit() {
        this.getCountries();
    }

    public async getCountries() {
        this.countries = await this.httpService.get("/api/countries/GetAll");
        console.log("countries, ", this.countries);
    }
}
