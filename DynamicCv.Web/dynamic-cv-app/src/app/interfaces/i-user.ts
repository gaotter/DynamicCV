import { IEntries } from './i-entires';

export interface ICvUser {
    id: number,
    firstName: string,
    lastName: string,
    about: {},
    role: string,
    userLogin: string,
    entries: IEntries[]
    loginStatus:string

}


export let initICvUser:ICvUser = {
    id: -1,
    about: '',
    entries: [],
    firstName: '',
    lastName: '',
    role: '',
    userLogin: '',
    loginStatus:''
  };
