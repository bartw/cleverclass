import { Injectable } from 'angular2/core';
import {Http} from 'angular2/http';

export interface ClassGroup {
    Id: number;
    Name: string;
}

@Injectable()
export class ClassGroupService {
    constructor(private http: Http) {}

    getClassGroups() {
        return this.http.get('api/classgroup').toPromise().then((response) => response.json());
    }
}
