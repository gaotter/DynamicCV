import {IProjects} from './i-projects';

export interface IEntries {
    id:number,
    title:string,
    contentText:string,
    areas: any[],
    projects:IProjects[]
}