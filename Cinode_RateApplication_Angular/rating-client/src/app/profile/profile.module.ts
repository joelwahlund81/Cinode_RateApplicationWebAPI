import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProfileComponent } from './profile.component';
import { ProfileSignUpComponent } from './profile-signup.component';
import { ProfileListComponent } from './profile-list.component';
import { ProfileListEntityComponent } from './profile-list-entity.component';

@NgModule({
  imports: [CommonModule],
  exports: [ProfileComponent],
  declarations: [
    ProfileComponent,
    ProfileSignUpComponent,
    ProfileListComponent,
    ProfileListEntityComponent,
  ],
})
export class ProfileModule {}
