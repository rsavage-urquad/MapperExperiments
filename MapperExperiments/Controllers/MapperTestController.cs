// Ignore Spelling: Mapperly

using AutoMapper;
using MapperExperiments.Classes;
using MapperExperiments.Classes.Interfaces;
using MapperExperiments.Classes.Mappers;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MapperExperiments.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MapperTestController : ControllerBase
    {
        private readonly ILogger<MapperTestController> _logger;
        private readonly IMapper _mapper;
        private readonly IAutoMapperTest _autoMapperTest;
        private readonly SourceItem _Source;
        private readonly TargetItem _Target;

        public MapperTestController(ILogger<MapperTestController> logger, IMapper mapper, IAutoMapperTest autoMapperTest)
        {
            _logger = logger;
            _mapper = mapper;
            _autoMapperTest = autoMapperTest;
            _Source = new SourceItem {
                InfoId = 1,
                PersonName = "Homer Simpson",
                City = "Springfield",
                State = "??",
                Zip = "12345",
                DateOfBirth = new DateTime(1980, 07, 22),
                Salary = 50000.00M
             };
            _Target = new TargetItem
            {
                InfoId = 2,
                PersonName = "Peter Griffin",
                City = "Quahog",
                State = "RI",
                ZipCode = "01234",
                DOB = new DateTime(1998, 12, 20),
                YearlyAmount = 60000.00M
            };
        }

        /// <summary>
        /// ManualMapSourceToTarget() - Tests Manual mapping from source to target
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ManualMapSourceToTarget")]
        public TargetItem ManualMapSourceToTarget()
        {
            ManualMapperTest mapper = new ManualMapperTest();
            return mapper.MapSourceToTarget(_Source);
        }

        /// <summary>
        /// ManualMapTargetToSource() - Tests Manual mapping from target to source
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ManualMapTargetToSource")]
        public SourceItem ManualMapTargetToSource()
        {
            ManualMapperTest mapper = new ManualMapperTest();
            return mapper.MapTargetToSource(_Target);
        }

        /// <summary>
        /// MapperlyMapSourceToTarget() - Tests Mapperly mapping from source to target
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("MapperlyMapSourceToTarget")]
        public TargetItem MapperlyMapSourceToTarget()
        {
            MapperlyTest mapper = new MapperlyTest();
            return mapper.MapSourceToTarget(_Source);
        }

        /// <summary>
        /// MapperlyMapTargetToSource() - Tests Mapperly mapping from target to source
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("MapperlyMapTargetToSource")]
        public SourceItem MapperlyMapTargetToSource()
        {
            MapperlyTest mapper = new MapperlyTest();
            return mapper.MapTargetToSource(_Target);
        }

        /// <summary>
        /// AutoMapperMapSourceToTarget() - Tests AutoMapper mapping from source to target
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("AutoMapperMapSourceToTarget")]
        public TargetItem AutoMapperMapSourceToTarget()
        {
            return _autoMapperTest.MapSourceToTarget(_Source); 
        }

        /// <summary>
        /// AutoMapperMapTargetToSource() - Tests AutoMapper mapping from target to source
        /// </summary>
        [HttpGet]
        [Route("AutoMapperMapTargetToSource")]
        public SourceItem AutoMapperMapTargetToSource()
        {
            return _autoMapperTest.MapTargetToSource(_Target);
        }

        /// <summary>
        /// TimeMethods() - Time the requested mapper while doing several (1 million) iterations
        /// </summary>
        /// <param name="mapperChoice">Expected 'Manual', 'Mapperly' or 'AutoMapper'</param>
        /// <returns>Elapsed time (ms)</returns>
        [HttpGet]
        [Route("TimerMethods")]
        public ActionResult<string> TimeMethods(string mapperChoice)
        {
            Stopwatch timer = new Stopwatch();
            long iterations = 1_000_000;
            switch (mapperChoice.ToLower())
            {
                case "manual":
                    timer.Start();
                    ManualMapperTest manualMapper = new ManualMapperTest();
                    for (int i = 0; i < iterations; i++)
                    {
                        TargetItem target = manualMapper.MapSourceToTarget(_Source);
                    }
                    timer.Stop();
                    break;

                case "mapperly":
                    timer.Start();
                    MapperlyTest mapperlyMapper = new MapperlyTest();
                    for (int i = 0; i < iterations; i++)
                    {
                        TargetItem target = mapperlyMapper.MapSourceToTarget(_Source);
                    }
                    timer.Stop();
                    break;

                case "automapper":
                    timer.Start();
                    for (int i = 0; i < iterations; i++)
                    {
                        TargetItem target = _autoMapperTest.MapSourceToTarget(_Source);
                    }
                    timer.Stop();
                    break;

                default:
                    return BadRequest("Unknown Mapper Choice.  Expected 'Manual', 'Mapperly' or 'AutoMapper'");
            }
            string result = $"{timer.ElapsedMilliseconds} ms";
            return Ok(result);
        }

    }
}