import React from 'react'
import ProjectCard from '@/app/dash/ProjectCard'
import { getProjects } from '@/services/projectServices'
import ProjectOptions from './ProjectOptions'



export default async function Dashboard() {
  const data = await getProjects()
  return (
    <>
      <div className='grid grid-cols-4 gap-4'>

        <nav>
          <ProjectOptions />
        </nav>
        <article className='col-span-3'>
          {data.map(
            obj => { 
              return <ProjectCard 
                name={obj.name}
                org={obj.organization}
                desc={obj.description}
                majors={obj.majors}
                comp={obj.compensation}
                key={obj.id} />
          })}
        </article>
      </div>
      
    </>
    
  )
}
