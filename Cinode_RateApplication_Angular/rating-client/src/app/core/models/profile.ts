import { Skills } from '.';

export class Profile {
  id?: number;
  firstName: string;
  fullName?: string;
  lastName: string;
  isAnonymous: boolean;
  skills: Skills[];
}
