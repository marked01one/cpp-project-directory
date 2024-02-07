import {Project} from '@/types'

export async function getProjects(): Promise<Project[]> {
    const res = await fetch("http://localhost:7001/api/projects");
  
    if (!res.ok) throw Error("Failed to fetch projects!");
    console.log(res.status.toString());
  
    return res.json();
  }