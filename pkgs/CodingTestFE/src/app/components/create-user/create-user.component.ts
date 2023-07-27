import { Component } from '@angular/core';

@Component({
  selector: 'cm-create-user',
  templateUrl: './create-user.component.html',
  styleUrls: ['./create-user.component.scss'],
})
export class CreateUserComponent {
  lastName: string = '';
  firstName: string = '';
}
