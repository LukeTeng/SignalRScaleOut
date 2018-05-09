import { Pipe, PipeTransform } from '@angular/core';
import { AppConfig,UserData } from '../../app.config';

@Pipe({name: 'systemText'})
export class SystemTextPipe implements PipeTransform {
  constructor(private appConfig: AppConfig) { }

  transform(value: string) {
    let lan = this.appConfig.userData.languageResource;
    if (lan[value])
      return lan[value];
    else
      return value;
  }
}