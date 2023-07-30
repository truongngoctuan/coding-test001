import { Component } from '@angular/core';
import { UserService } from 'src/services/user.service';

@Component({
  selector: 'cm-create-user',
  templateUrl: './create-user.component.html',
  styleUrls: ['./create-user.component.scss'],
})
export class CreateUserComponent {
  constructor(private userService: UserService) { }
  lastName: string = '';
  firstName: string = '';
  onSubmit() {
    console.log('on submit');
    console.log(this.lastName, this.firstName);
    this.userService.addUser({
      lastName: this.lastName,
      firstName: this.firstName,
    });
    this.resetForm();
  }

  resetForm() {
    this.lastName = "";
    this.firstName = "";
  }
}
