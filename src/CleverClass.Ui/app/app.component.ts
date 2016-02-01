import { Component, OnInit } from 'angular2/core';
import 'rxjs/Rx';
import { ClassGroup, ClassGroupService } from './classGroup.service';

@Component({
    selector: 'my-app',
    template: `
        <h1>{{title}}</h1>
        <ul>
            <li *ngFor="#classGroup of classGroups">{{classGroup.Name}}</li>
        </ul>
    `,
    bindings: [ClassGroupService]
})
export class AppComponent implements OnInit {
    public title = 'Clever Class';
    public classGroups: ClassGroup[];

    constructor(private _classGroupService: ClassGroupService) { }

    getClassGroups() {
        this.classGroups = [];
        this._classGroupService.getClassGroups().then(classGroups => this.classGroups = classGroups);
        return this.classGroups;
    }

    ngOnInit() {
        this.classGroups = this.getClassGroups();
    }
}
