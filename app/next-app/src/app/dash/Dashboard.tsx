import React from 'react'
import ProjectCard from '@/app/dash/ProjectCard'
import { getProjects } from '@/services/projectServices'
import { Card } from 'flowbite-react'



export default async function Dashboard() {
  const data = await getProjects()
  console.log(data)
  
  return (
    <>
      <h1 className='text-4xl text-center font-bold mt-4 mb-6'>Project Dashboard</h1>
      <div className='grid grid-cols-4 gap-4'>

        <nav>
          <Card className='my-2'>
            <h1 className='text-2xl font-bold dark:text-gray-300'>Hello World!</h1>
          </Card>
        </nav>
        <article className='col-span-3'>
          {data.map(
            obj => { 
              return <ProjectCard 
                name={obj.name}
                org={obj.organization}
                desc={obj.description} 
                majors={obj.majors} 
                key={obj.id}
              />
          })}
        </article>
      </div>
      
    </>
    
  )
}
