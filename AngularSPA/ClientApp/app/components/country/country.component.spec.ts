/// <reference path="../../../../node_modules/@types/jasmine/index.d.ts" />
import { assert } from 'chai';
import { HttpModule, Http } from '@angular/http'
import { CountryComponent } from './country.component';
import { TestBed, async, ComponentFixture } from '@angular/core/testing';
import { HttpService } from '../../shared/services/http.service';

let fixture: ComponentFixture<CountryComponent>;

describe('Country component', () => {
    beforeEach(() => {
        TestBed.configureTestingModule({ imports: [ HttpModule], declarations: [CountryComponent], providers: [HttpService] });
        fixture = TestBed.createComponent(CountryComponent);
        fixture.detectChanges();
    });

    it('should display a title', async(() => {
        const titleText = fixture.nativeElement.querySelector('h1').textContent;
        expect(titleText).toEqual('country list');
    }));

});
