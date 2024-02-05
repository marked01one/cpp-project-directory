import React from 'react'
import ProjectCard from '@/app/components/ProjectCard'
import { getProjects } from '../services/projectServices'



export default async function Dashboard() {
  const data = await getProjects()
  
  return (
    <>
      <p className='text-3xl'>Project Dashboard</p>
      {(data.map(obj => {
        return (
          <ProjectCard 
            name={obj.name} 
            oragnization={obj.organization} 
            description={obj.description} />
        )
      }))}
    </>
    
  )
}
