import React from 'react'
import ProjectCard from '@/app/dash/ProjectCard'
import { getProjects } from '@/services/projectServices'
import ProjectOptions from './ProjectFilters'
import ProjectFilters from './ProjectFilters'



export default async function Dashboard() {
  const data = await getProjects()
  return (
      <div className='lg:grid grid-cols-4'>
        <nav>
          <ProjectFilters />
        </nav>
        <article className='col-span-3'>
          {data.map(proj => { 
            return <ProjectCard proj={proj} key={proj.id}  />
          })}
        </article>
      </div>
  )
}
